# Reto 5: Question Description
Sam and Kelly are programming buddies. Kelly resolves to practice more as Sam isa head initially.
They each solve a number of problems daily. Find the mínimum number or days for Kelly to have
solved more problems than Sam. If Kelly cannot surpass retum -1.
Example
```
SamDaily = 3
KellyDaily = 5
Difference = 5
```
Initially, Sam has solved difference problems more than Kelly. Each day, they solve samDaily and
kellyDaily problems each.
```
Day 1: samSolved = difference + samDaily = 5 + 3 = 8
kellySolved = kellyDaily = 5
Day 2: samSolved = 8 + 3 = 11
kellySolved = 5 + 5 = 10
Day 3: samSolved = 11 + 3 = 14
kellySolved = 10 + 5 = 15
```

Sam is 5 problems ahead of Kelly and they solve 3 and 5 problems a day. Sam will be ahead by only
3 after the first day, 1 after the second, and Kelly will pass Sam on day 3.
Function Description
Complete the function minNum in the editor below.
MinNum has the following parameter(s):
SamDaily: Number of problems Sam solves in a day
KellyDaily: Number of problems Kelly solves in a day
Difference: Number of problems Sam isa head to begin
Return
Int: the minimum number of days needed by Kelly to exceed Samm, or -1 if it is imposible
Constraints
```
• 1 ≤ 𝑠𝑎𝑚𝐷𝑎𝑖𝑙𝑦, 𝑘𝑒𝑙𝑙𝑦𝐷𝑎𝑖𝑙𝑦 ≤ 100
• 0 ≤ 𝑑𝑖𝑓𝑓𝑒𝑟𝑒𝑛𝑐𝑒 ≤ 100
```
Input format for Custom Testing
Input from stdin will be processed as follows and passed to the fuction.
The first line contains an integer samDaily.
The second line contains an integer kellyDaily.
The third line contains an integer ahead