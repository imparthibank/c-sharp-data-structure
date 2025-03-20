-- Create a Composite Type technical_alias_type
CREATE TYPE upsert_technical_alias_type AS
(
	aliasid integer,
	aliasname character varying(50),
	region character varying(15),
	tradingstyle character varying(100),
	media character varying(50),
	mediatype character varying(50),
	fixconnector character varying(100),
	externalaliasname character varying(50),
	isactive boolean
);

-- create fn_upsert_technical_alias function for alias insert / update
CREATE OR REPLACE FUNCTION fn_upsert_technical_alias(p_alias upsert_technical_alias_type)
RETURNS INTEGER
LANGUAGE plpgsql AS $$
DECLARE
    v_aliasid INTEGER;
BEGIN
    IF p_alias.aliasid IS NULL OR p_alias.aliasid = 0 THEN
        -- Insert logic
        INSERT INTO dbo.tbo_fxcstrmediaalias (
            name, region, tradingstyle, media, type, fixconnector, externalaliasname, isactivated
        ) VALUES (
            p_alias.aliasname, p_alias.region, p_alias.tradingstyle, p_alias.media, p_alias.mediatype,
            p_alias.fixconnector, p_alias.externalaliasname, p_alias.isactivated
        ) RETURNING aliasid INTO v_aliasid;
    ELSE
        -- Update logic
        UPDATE dbo.tbo_fxcstrmediaalias
        SET name = p_alias.aliasname,
            region = p_alias.region,
            tradingstyle = p_alias.tradingstyle,
            media = p_alias.media,
            type = p_alias.mediatype,
            fixconnector = p_alias.fixconnector,
            externalaliasname = p_alias.externalaliasname,
            isactivated = p_alias.isactivated
        WHERE aliasid = p_alias.aliasid
        RETURNING aliasid INTO v_aliasid;
    END IF;

    RETURN v_aliasid;
END;
$$;

----------------------------------------------------
SELECT sp_upsert_technical_alias(ROW(
    NULL, -- aliasid (NULL means new record)
    'AliasName1', -- name
    'US', -- region
    'Scalping', -- tradingstyle
    'Bloomberg', -- media
    'Equity', -- type
    'FIX_4.4', -- fixconnector
    'ExternalAlias_1', -- externalaliasname
    TRUE -- isactivated
)::technical_alias_type);

----------------------------------------------------
SELECT sp_upsert_technical_alias(ROW(
    1, -- aliasid (Existing ID to update)
    'UpdatedAlias', -- name
    'UK', -- region
    'Swing', -- tradingstyle
    'Reuters', -- media
    'Forex', -- type
    'FIX_5.0', -- fixconnector
    'ExternalAlias_Updated', -- externalaliasname
    FALSE -- isactivated
)::technical_alias_type);
----------------------------------------------------