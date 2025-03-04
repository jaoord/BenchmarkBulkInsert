# Benchmark Bulk Inserts
Quick test to see what is the fastest way to bulk insert data into a database.
The goal is to see what bulk insert strategy is the fastest. 
We don't want duplicate data but we also want it to be fast.
Here we will test the following strategies:

1) Before insert, check if the data exists. We will optimize this by using AsNoTracking(). (N+1)
2) Insert and ignore duplicates, by means of a unique constraint and ignore errors
3) Insert unless the data exists by performing a INSERT ... WHERE NOT EXISTS. This means doing a raw SQL query
4) Performing an INSERT OR IGNORE INTO statement
5) Temporary Table. Insert all data into a temporary table (using bulk insert) and then insert the data into the main table that doesn't already exist


# Results
The results are as follows:


## 1). N+1
	Benchmark 1 (1/5) completed in 1030 ms
	Benchmark 1 (2/5) completed in 858 ms
	Benchmark 1 (3/5) completed in 867 ms
	Benchmark 1 (4/5) completed in 660 ms
	Benchmark 1 (5/5) completed in 506 ms
	Benchmark completed in 3923 ms (avg: 784)

## 2). Insert and ignore duplicates
	Benchmark 2 (1/5) completed in 4163 ms
	Benchmark 2 (2/5) completed in 540 ms
	Benchmark 2 (3/5) completed in 461 ms
	Benchmark 2 (4/5) completed in 467 ms
	Benchmark 2 (5/5) completed in 457 ms
	Benchmark completed in 6091 ms (avg: 1218)

## 3). Insert where not exists
	Benchmark 3 (1/5) completed in 2152 ms
	Benchmark 3 (2/5) completed in 482 ms
	Benchmark 3 (3/5) completed in 434 ms
	Benchmark 3 (4/5) completed in 426 ms
	Benchmark 3 (5/5) completed in 435 ms
	Benchmark completed in 3931 ms (avg: 786)

## 4). Insert or ignore
	Benchmark 4 (1/5) completed in 2123 ms
	Benchmark 4 (2/5) completed in 1944 ms
	Benchmark 4 (3/5) completed in 1943 ms
	Benchmark 4 (4/5) completed in 1926 ms
	Benchmark 4 (5/5) completed in 1927 ms
	Benchmark completed in 9866 ms (avg: 1973)

## 5). Temporary Table
	Benchmark 5 (1/5) completed in 419 ms
	Benchmark 5 (2/5) completed in 638 ms
	Benchmark 5 (3/5) completed in 696 ms
	Benchmark 5 (4/5) completed in 456 ms
	Benchmark 5 (5/5) completed in 463 ms
	Benchmark completed in 2675 ms (avg: 535)