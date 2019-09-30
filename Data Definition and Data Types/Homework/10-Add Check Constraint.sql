 ALTER TABLE Users
 ADD CONSTRAINT CH_MinSymbols CHECK(LEN([Password]) >= 5)