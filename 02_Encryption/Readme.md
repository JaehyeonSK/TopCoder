# 02. 암호 
### Cryptography SRM480 Div 2 Level 1
TopCode Security Agency (TSA, established today) has just invented a new encryption system! This encryption system takes as its input a list of numbers to encrypt.  
You work at TSA and your task is to implement a very important part of the enryption process. You are allowed to pick one number in the input list and increment its value by 1. This should be done in such way that the product of all numbers in the list after this change becomes as large as possible.  
Given the list of number as int[] numbers, return the maximum product you can obtain. It is guaranteed that the return value will not exceed 2^62.