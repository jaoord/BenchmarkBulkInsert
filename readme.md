# Benchmark Bulk Inserts
Quick test to see what is the fastest way to bulk insert data into a database. This is in no way meant to be a beautiful coding excersize, or a very scientific approach. 
Instead, the goal is to see what bulk insert strategy is the fastest under normal circumstances. 
We don't want duplicate data but we also want it to be fast.

## The strategies
Here we will test the following strategies:

1) Before insert, check if the data exists. We will optimize this by using AsNoTracking(). (N+1)
2) Same as above but without tracking
3) Insert and ignore duplicates, by means of a unique constraint and ignore errors
4) Insert unless the data exists by performing a INSERT ... WHERE NOT EXISTS. This means doing a raw SQL query
5) Performing an INSERT OR IGNORE INTO statement
6) Temporary Table. Insert all data into a temporary table (using bulk insert) and then insert the data into the main table that doesn't already exist
7) Cache the latest data and only insert the new data. Use a batch size of 1000 to insert the new data.

# Results
The results are as follows:


## 1). N+1
	Benchmark 1 (1/5) completed in 1051 ms
	Benchmark 1 (2/5) completed in 859 ms
	Benchmark 1 (3/5) completed in 872 ms
	Benchmark 1 (4/5) completed in 675 ms
	Benchmark 1 (5/5) completed in 508 ms
	Benchmark completed in 3968 ms (avg: 793)

## 2). N+1 No tracking
	Benchmark 2 (1/5) completed in 1021 ms
	Benchmark 2 (2/5) completed in 851 ms
	Benchmark 2 (3/5) completed in 867 ms
	Benchmark 2 (4/5) completed in 658 ms
	Benchmark 2 (5/5) completed in 499 ms
	Benchmark completed in 3898 ms (avg: 779)

## 3). Insert and ignore duplicates
	Benchmark 2 (1/5) completed in 4163 ms
	Benchmark 2 (2/5) completed in 540 ms
	Benchmark 2 (3/5) completed in 461 ms
	Benchmark 2 (4/5) completed in 467 ms
	Benchmark 2 (5/5) completed in 457 ms
	Benchmark completed in 6091 ms (avg: 1218)

## 4). Insert where not exists
	Benchmark 3 (1/5) completed in 2152 ms
	Benchmark 3 (2/5) completed in 482 ms
	Benchmark 3 (3/5) completed in 434 ms
	Benchmark 3 (4/5) completed in 426 ms
	Benchmark 3 (5/5) completed in 435 ms
	Benchmark completed in 3931 ms (avg: 786)

## 5). Insert or ignore
	Benchmark 4 (1/5) completed in 2123 ms
	Benchmark 4 (2/5) completed in 1944 ms
	Benchmark 4 (3/5) completed in 1943 ms
	Benchmark 4 (4/5) completed in 1926 ms
	Benchmark 4 (5/5) completed in 1927 ms
	Benchmark completed in 9866 ms (avg: 1973)

## 6). Temporary Table
	Benchmark 5 (1/5) completed in 419 ms
	Benchmark 5 (2/5) completed in 638 ms
	Benchmark 5 (3/5) completed in 696 ms
	Benchmark 5 (4/5) completed in 456 ms
	Benchmark 5 (5/5) completed in 463 ms
	Benchmark completed in 2675 ms (avg: 535)

## 7). Cache lookup and batch insert
	Benchmark 7 (1/5) completed in 381 ms
	Benchmark 7 (2/5) completed in 49 ms
	Benchmark 7 (3/5) completed in 20 ms
	Benchmark 7 (4/5) completed in 20 ms
	Benchmark 7 (5/5) completed in 19 ms
	Benchmark completed in 490 ms (avg: 98)