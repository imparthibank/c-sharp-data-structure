-- Drop tables if they exist to avoid conflicts
DROP TABLE IF EXISTS dbo.fxc_client_profile_mapping CASCADE;
DROP TABLE IF EXISTS dbo.alias_profile_mapping CASCADE;
DROP TABLE IF EXISTS dbo.fxc_streaming_profile_grid CASCADE;
DROP TABLE IF EXISTS dbo.fxc_streaming_bucket_profile_grid CASCADE;
DROP TABLE IF EXISTS dbo.fxc_streaming_media_alias CASCADE;
DROP TABLE IF EXISTS dbo.fxc_profile CASCADE;

-- Ensure dbo schema exists
CREATE SCHEMA IF NOT EXISTS dbo;

-- Create fxc_profile table
CREATE TABLE dbo.fxc_profile (
    profile_id BIGINT PRIMARY KEY,
    ptp_id INTEGER NOT NULL,
    profile_type_id INTEGER NOT NULL,
    profile_name VARCHAR NOT NULL,
    version INTEGER NOT NULL
);

-- Create fxc_client_profile_mapping table
CREATE TABLE dbo.fxc_client_profile_mapping (
    client_id BIGINT NOT NULL,
    ptp_id BIGINT NOT NULL,
    profile_id BIGINT NOT NULL,
    version INTEGER,
    PRIMARY KEY (client_id, ptp_id, profile_id),
    CONSTRAINT fk_fxc_client_profile FOREIGN KEY (profile_id) REFERENCES dbo.fxc_profile (profile_id)
);

-- Create alias_profile_mapping table
CREATE TABLE dbo.alias_profile_mapping (
    alias_id BIGINT NOT NULL,
    ptp_id BIGINT NOT NULL,
    profile_id BIGINT NOT NULL,
    version INTEGER,
    PRIMARY KEY (alias_id, ptp_id, profile_id),
    CONSTRAINT fk_alias_profile FOREIGN KEY (profile_id) REFERENCES dbo.fxc_profile (profile_id),
    CONSTRAINT uq_alias_profile UNIQUE (alias_id, ptp_id, profile_id)
);

-- Create fxc_streaming_profile_grid table
CREATE TABLE dbo.fxc_streaming_profile_grid (
    profile_id BIGINT NOT NULL,
    sequence INTEGER NOT NULL,
    currency_scope VARCHAR,
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
    CONSTRAINT fk_fxc_streaming_profile FOREIGN KEY (profile_id) REFERENCES dbo.fxc_profile (profile_id)
);

-- Create fxc_streaming_bucket_profile_grid table
CREATE TABLE dbo.fxc_streaming_bucket_profile_grid (
    profile_id BIGINT NOT NULL,
    sequence INTEGER NOT NULL,
    currency_pair VARCHAR,
    bucket_result VARCHAR,
    PRIMARY KEY (profile_id, sequence),
    CONSTRAINT fk_fxc_streaming_bucket FOREIGN KEY (profile_id) REFERENCES dbo.fxc_profile (profile_id)
);

-- Create fxc_streaming_media_alias table
CREATE TABLE dbo.fxc_streaming_media_alias (
    alias_id INTEGER PRIMARY KEY,
    name VARCHAR NOT NULL,
    region VARCHAR,
    trading_style VARCHAR,
    media VARCHAR NOT NULL,
    type VARCHAR NOT NULL,
    fix_connector VARCHAR NOT NULL,
    external_alias_name VARCHAR NOT NULL,
    is_activated BOOLEAN,
    CONSTRAINT uq_fxc_streaming_media UNIQUE (name, media)
);

-- Indexes for performance optimization
CREATE INDEX IF NOT EXISTS idx_fxc_profile_ptp_id ON dbo.fxc_profile (ptp_id);
CREATE INDEX IF NOT EXISTS idx_fxc_client_profile_mapping_profile_id ON dbo.fxc_client_profile_mapping (profile_id);
CREATE INDEX IF NOT EXISTS idx_alias_profile_mapping_profile_id ON dbo.alias_profile_mapping (profile_id);
CREATE INDEX IF NOT EXISTS idx_fxc_streaming_profile_grid_profile_id ON dbo.fxc_streaming_profile_grid (profile_id);
CREATE INDEX IF NOT EXISTS idx_fxc_streaming_bucket_profile_grid_profile_id ON dbo.fxc_streaming_bucket_profile_grid (profile_id);
