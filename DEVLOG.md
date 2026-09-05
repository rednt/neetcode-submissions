# DSA Practice Log

| # | Problem | Pattern | Time/Space | Alt Approach | Retry Date | Retried |
|---|---------|---------|------------|--------------|------------|----------------|
| 1 | Contains Duplicate | Seen-Set (HashSet) | O(n) / O(n) | Sort+scan O(n log n)/O(1) | Sept 4 | Yes |
| 2 | Valid Anagram | Frequency Array / Map | O(n) / O(1)* | Sort+Compare O(n log n)/O(n) | Sept 5 | Yes |
| 3 | Two Sum | One-pass hash map | O(n) / O(n) | Two pointers on Sorted array O(n log n)/O(n) | Sept 6 |
| 4 | Group Anagrams| Sort + hashmap | O(m∗nlogn) / O(m∗n) | Hash Table O(m∗n)/O(m) | Sept 7 |
| 5	| Top K Frequent | Elements	Hashmap + Sort by frequency |	O(n log n) / O(n) |	Bucket sort O(n) / O(n) |	Sept 8 |
| 6	| Encode and Decode Strings | String manipulation | O(m+n) / O(m+n) |	Attach each string to its length. We write `length#string` |	Sept 9 
| 7	| Products of Array Except Self | Suffix prefix arrays | O(n) / O(1) | Compute the total product of all elements, then for each index just divide out that element: `ans[i] = totalProduct / nums[i]` |	Sept 10 |
| 8	| Valid Sudoku | One pass hashset | O(1) / O(1) (fixed number - 9x9) | Bitmasking instead of hash sets |	Sept 11 |
| 9	| Longest Consecutive Sequence | Hash Set| O(n) / O(n) | Sorting O(nlogn) / O(n) |	Sept 12 |
| 10	| Valid Palindrome | Two Pointers | O(n) / O(1) | Reverse string O(n) / O(n) |	Sept 13 |
| 11	| Two Integer Sum II | Two Pointers | O(n) / O(1) | Binary search O(nlogn) / O(1) |	Sept 15 |
