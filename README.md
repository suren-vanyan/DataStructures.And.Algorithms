# ☝ Note that this repository  is meant to be used for learning  purposes 

## :pushpin: Algorithm Complexity Analysis
| Language | Content |
|:--------------|:----------------:|
| :ru: | [:white_check_mark:](https://habr.com/ru/post/196560/) 
| :us: | [:white_check_mark:](http://discrete.gr/complexity/)

## :ballot_box_with_check: Implemented Algorithms
| Algorithm | C# |
|:--------------|:----------------:|
| [Bubble Sort](https://en.wikipedia.org/wiki/Bubble_sort) |  [:white_check_mark:](https://github.com/suren-vanyan/DataStructures.And.Algorithms/blob/master/Sorting%20Algorithms/BubleSortImplement/BubleSortImplement/Program.cs) 
[Selection Sort](https://www.geeksforgeeks.org/selection-sort/) |  [:white_check_mark:](https://github.com/suren-vanyan/DataStructures.And.Algorithms/tree/master/Sorting%20Algorithms/SelectSortImplement) 
| [Insertion Sort](https://en.wikipedia.org/wiki/Insertion_sort) |  [:white_check_mark:]() 
| [Binary Search](https://en.wikipedia.org/wiki/Binary_search_algorithm) | [:white_check_mark:]( )
| [Quicksort](https://en.wikipedia.org/wiki/Quicksort) | [:white_check_mark:](https://github.com/suren-vanyan/DataStructures.And.Algorithms/blob/master/Sorting%20Algorithms/QuickSortImplement/QuickSortImplement/Program.cs)
| [QuickSortFromBookRobertSedgewick](https://en.wikipedia.org/wiki/Quicksort) | [:white_check_mark:](https://github.com/suren-vanyan/DataStructures.And.Algorithms/blob/master/Sorting%20Algorithms/QuickSortFromBookRobertSedgewick/QuickSortFromBookRobertSedgewick/Program.cs)
| [Merge Sort](https://www.khanacademy.org/computing/computer-science/algorithms/merge-sort/a/overview-of-merge-sort) |   [:white_check_mark:](https://github.com/suren-vanyan/DataStructures.And.Algorithms/blob/master/Sorting%20Algorithms/MergeSortImplement/MergeSortImplement/Program.cs)

## :ballot_box_with_check: Implemented Data Structures
| Lists: | C# |
|:--------------|:----------------:|
| [Linked list](https://en.wikipedia.org/wiki/Linked_list) |  [:white_check_mark:](https://github.com/suren-vanyan/DataStructures.And.Algorithms/tree/master/DataStructures.SinglyLinkedList/SinglyList) 

| Trees: | C# |
|:--------------|:----------------:|
| [](https://en.wikipedia.org/wiki/Linked_list) |  [:white_check_mark:]() 


## Useful Information

### References

[▶ Data Structures and Algorithms on YouTube](https://www.youtube.com/playlist?list=PLLXdhg_r2hKA7DPDsunoDZ-Z769jWn4R8)

### Big O Notation

*Big O notation* is used to classify algorithms according to how their running time or space requirements grow as the input size grows.
On the chart below you may find most common orders of growth of algorithms specified in Big O notation.

![big-o-graph](https://user-images.githubusercontent.com/38188753/51407910-9b790000-1b76-11e9-9e63-03342a95bf73.png)


Source: [Big O Cheat Sheet](http://bigocheatsheet.com/).

Below is the list of some of the most used Big O notations and their performance comparisons against different sizes of the input data.

| Big O Notation | Computations for 10 elements | Computations for 100 elements | Computations for 1000 elements  |
| -------------- | ---------------------------- | ----------------------------- | ------------------------------- |
| **O(1)**       | 1                            | 1                             | 1                               |
| **O(log N)**   | 3                            | 6                             | 9                               |
| **O(N)**       | 10                           | 100                           | 1000                            |
| **O(N log N)** | 30                           | 600                           | 9000                            |
| **O(N^2)**     | 100                          | 10000                         | 1000000                         |
| **O(2^N)**     | 1024                         | 1.26e+29                      | 1.07e+301                       |
| **O(N!)**      | 3628800                      | 9.3e+157                      | 4.02e+2567                      |

### Data Structure Operations Complexity

| Data Structure          | Access    | Search    | Insertion | Deletion  | Comments  |
| ----------------------- | :-------: | :-------: | :-------: | :-------: | :-------- |
| **Array**               | 1         | n         | n         | n         |           |
| **Stack**               | n         | n         | 1         | 1         |           |
| **Queue**               | n         | n         | 1         | 1         |           |
| **Linked List**         | n         | n         | 1         | 1         |           |
| **Hash Table**          | -         | n         | n         | n         | In case of perfect hash function costs would be O(1) |
| **Binary Search Tree**  | n         | n         | n         | n         | In case of balanced tree costs would be O(log(n)) |
| **B-Tree**              | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **Red-Black Tree**      | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **AVL Tree**            | log(n)    | log(n)    | log(n)    | log(n)    |           |
| **Bloom Filter**        | -         | 1         | 1         | -         | False positives are possible while searching |

### Array Sorting Algorithms Complexity

| Name                  | Best            | Average             | Worst               | Memory    | Stable    | Comments  |
| --------------------- | :-------------: | :-----------------: | :-----------------: | :-------: | :-------: | :-------- |
| **Bubble sort**       | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Yes       |           |
| **Insertion sort**    | n               | n<sup>2</sup>       | n<sup>2</sup>       | 1         | Yes       |           |
| **Selection sort**    | n<sup>2</sup>   | n<sup>2</sup>       | n<sup>2</sup>       | 1         | No        |           |
| **Heap sort**         | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | 1         | No        |           |
| **Merge sort**        | n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | n         | Yes       |           |
| **Quick sort**        | n&nbsp;log(n)   | n&nbsp;log(n)       | n<sup>2</sup>       | log(n)    | No        | Quicksort is usually done in-place with O(log(n)) stack space |
| **Shell sort**        | n&nbsp;log(n)   | depends on gap sequence   | n&nbsp;(log(n))<sup>2</sup>  | 1         | No         |           |
| **Counting sort**     | n + r           | n + r               | n + r               | n + r     | Yes       | r - biggest number in array |
| **Radix sort**        | n * k           | n * k               | n * k               | n + k     | Yes       | k - length of longest key |
