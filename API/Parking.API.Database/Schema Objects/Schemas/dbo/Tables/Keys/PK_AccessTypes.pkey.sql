﻿ALTER TABLE [dbo].[AccessTypes]
    ADD CONSTRAINT [PK_AccessTypes] PRIMARY KEY CLUSTERED ([AccessTypeId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

