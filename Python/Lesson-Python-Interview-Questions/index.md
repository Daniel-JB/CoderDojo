
<style> 
 .markdown-body table {
   margin-bottom: -40px;
 }
 
 .markdown-body tbody {
    border-top: 2px solid #FFFFFF;
    border-bottom: 2px solid #FFFFFF;
    background-color: #FFFFFF;
}
 
.markdown-body td {
    border-right: 1px solid #FFFFFF;
    border-bottom: 1px solid #FFFFFF;
    padding: 5px;
}
</style>

| [<< back](../)                  | [Home](https://daniel-jb.github.io/CoderDojo)      |
| -------------                   | -----:                                             |
|              |       |

<br />

### Generic Questions
1) How would you swap two variables
```Python
 x, y = y, x
```

### Array Questions
1) What would the output be for the following array ll = [0, 1, 2, 3, 4, 5]. Take each answer as if array has been reset
```Python
 a) del ll[0]    - [1, 2, 3, 4, 5] 
 b) ll.pop(0)    - [1, 2, 3, 4, 5] 
 c) ll.pop(-1)   - [0, 1, 2, 3, 4] 
 d) ll.remove(3) - [0, 1, 2, 4, 5] 
```


2) What would be the output for the following array ll = [0, 1, 2, 3, 4, 5]. Take each answer as if array has been reset
```Python
 a) ll[:3]      - [0, 1, 2] 
 b) ll[3:]      - [3, 4, 5] 
 c) ll[0:-1:2]  - [0, 2, 4] 
```

3) What is the following output of list(map(lambda n: n * 2, [1, 2, 3, 4, 5]))
```Python
[2, 4, 6, 8, 10]
```

### Code questions
1) Create palindrome
```Python
def palindrome(s):
    i = 0
    while i <= len(s) / 2:
        if s[i] != s[-i - 1]:
            return False
        i += 1
    return True
```

2) Create fizz buzz
```
for fizzbuzz in range(51):
    if fizzbuzz % 3 == 0 and fizzbuzz % 5 == 0:
        print("fizzbuzz")
        continue
    elif fizzbuzz % 3 == 0:
        print("fizz")
        continue
    elif fizzbuzz % 5 == 0:
        print("buzz")
        continue
    print(fizzbuzz)
```
