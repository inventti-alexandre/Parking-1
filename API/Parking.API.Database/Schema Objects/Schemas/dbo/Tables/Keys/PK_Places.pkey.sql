﻿ALTER TABLE [dbo].[Places]
    ADD CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED ([PlaceId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

