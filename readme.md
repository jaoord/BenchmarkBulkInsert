# Benchmark Bulk Inserts
Quick test to see what is the fastest way to bulk insert data into a database.
The goal is to see what bulk insert strategy is the fastest. 
We don't want duplicate data but we also want it to be fast.
Here we will test the following strategies:

* Before insert, check if the data exists. We will optimize this by using AsNoTracking(). (N+1)
* Insert and ignore duplicates, by means of a unique constraint and ignore errors
* Insert unless the data exists by performing a INSERT ... WHERE NOT EXISTS. This means doing a raw SQL query
* Performing an INSERT OR IGNORE INTO statement
* Temporary Table. Insert all data into a temporary table (using bulk insert) and then insert the data into the main table that doesn't already exist
