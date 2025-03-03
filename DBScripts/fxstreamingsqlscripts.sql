-- Ensure the schema exists
CREATE SCHEMA IF NOT EXISTS dbo;

-- Drop existing tables in correct order due to dependencies
DROP TABLE IF EXISTS dbo.fxc_streaming_bucket_profile_grid CASCADE;
DROP TABLE IF EXISTS dbo.fxc_streaming_profile_grid CASCADE;
DROP TABLE IF EXISTS dbo.fxc_streaming_media_alias CASCADE;
DROP TABLE IF EXISTS dbo.fxc_client_profile_mapping CASCADE;
DROP TABLE IF EXISTS dbo.alias_to_profile_mapping CASCADE;
DROP TABLE IF EXISTS dbo.fxc_profile CASCADE;

-- Create fxc_profile Table
CREATE TABLE IF NOT EXISTS dbo.fxc_profile (
    profile_id BIGINT PRIMARY KEY,
    ptpid INTEGER NOT NULL,
    profile_type_id INTEGER NOT NULL,
    profile_name VARCHAR NOT NULL,
    version INTEGER NOT NULL
);

-- Create alias_to_profile_mapping Table
CREATE TABLE IF NOT EXISTS dbo.alias_to_profile_mapping (
    alias_id BIGINT NOT NULL,
    ptpid BIGINT NOT NULL,
    profile_id BIGINT NOT NULL,
    version INTEGER,
    PRIMARY KEY (alias_id, ptpid, profile_id),
    CONSTRAINT fk_alias_to_profile_mapping_profile FOREIGN KEY (profile_id) 
        REFERENCES dbo.fxc_profile(profile_id) ON DELETE CASCADE
);

-- Create fxc_client_profile_mapping Table
CREATE TABLE IF NOT EXISTS dbo.fxc_client_profile_mapping (
    client_id BIGINT NOT NULL,
    ptpid BIGINT NOT NULL,
    profile_id BIGINT NOT NULL,
    version INTEGER,
    PRIMARY KEY (client_id, ptpid, profile_id),
    CONSTRAINT fk_fxc_client_profile_mapping_profile FOREIGN KEY (profile_id) 
        REFERENCES dbo.fxc_profile(profile_id) ON DELETE CASCADE
);

-- Create fxc_streaming_media_alias Table
CREATE TABLE IF NOT EXISTS dbo.fxc_streaming_media_alias (
    alias_id INTEGER NOT NULL PRIMARY KEY,
    name VARCHAR NOT NULL,
    region VARCHAR,
    trading_style VARCHAR,
    media VARCHAR NOT NULL
);

-- Create fxc_streaming_profile_grid Table
CREATE TABLE IF NOT EXISTS dbo.fxc_streaming_profile_grid (
    profile_id BIGINT NOT NULL,
    sequence INTEGER NOT NULL,
    currency_pair VARCHAR,
    applied_to_inverted_ccy BOOLEAN,
    is_onshore VARCHAR,
    tenor_code_start VARCHAR,
    tenor_code_end VARCHAR,
    margin_bid DOUBLE PRECISION,
    margin_ask DOUBLE PRECISION,
    margin_unit VARCHAR,
    tiering VARCHAR,
    reject BOOLEAN,
    PRIMARY KEY (profile_id, sequence),
    CONSTRAINT fk_fxc_streaming_profile_grid_profile FOREIGN KEY (profile_id) 
        REFERENCES dbo.fxc_profile(profile_id) ON DELETE CASCADE
);

-- Create fxc_streaming_bucket_profile_grid Table
CREATE TABLE IF NOT EXISTS dbo.fxc_streaming_bucket_profile_grid (
    profile_id BIGINT NOT NULL,
    sequence INTEGER NOT NULL,
    currency_pair VARCHAR,
    bucket_result VARCHAR,
    PRIMARY KEY (profile_id, sequence),
    CONSTRAINT fk_fxc_streaming_bucket_profile_grid_profile FOREIGN KEY (profile_id) 
        REFERENCES dbo.fxc_profile(profile_id) ON DELETE CASCADE
);
