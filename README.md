Webassign-Solver
================

Solves math and physics problems on webassign.net automatically. This works by finding patterns in the practice problems and using those patterns to generate a solution for the variables you have been given.

TUTORIAL:

Sample problem: 
A motorbike traveling along a straight road increases its speed from v1 = 20m/s to v2 = 40m/s in 5 seconds. If the acceleration is constant, what is the distance traveled during this time?

We're also given the practice problem:
     - A motorbike traveling along a straight road increases its speed from v1 = 30m/s to v2 = 50m/s in 6 seconds. If the acceleration is constant, what is the distance traveled during this time?
The answer to this problem (which is given to us by Webassign) is 240

We should reload the Webassign assignment to get a second practice problem:
     - A motorbike traveling along a straight road increases its speed from v1 = 10m/s to v2 = 33m/s in 4 seconds. If the acceleration is constant, what is the distance traveled during this time?
The answer to this problem (which is given to us by Webassign) is 86

So, in each of these three versions of the same problem, we are given three variables:
 	* The starting velocity. Let's call this variable A.
 	* The ending velocity. Let's call this variable B.
 	* The duration. Let's call this variable C.
 	* The ANSWER. Let's call this variable "answer".

In practice problem 1:
	A = 30
	B = 50
	C = 6
	answer = 240

In practice problem 2:
	A = 10
	B = 33
	C = 4
	answer = 86

We should enter these 8 pieces of data into the Webassign Solver program. Then click "Solve"

The following output appears:
		Constant array: 40 			Score: 100 (0%)
		Average constant value: 1 	A= 30   B= 50   C= 6

		Constant array: 12 			Score: 29.75 (1.405%)
		Average constant value: -4.82425539034587 	A= 50   B= 6   C= 30

		Constant array: 32 			Score: 11.4 (1.772%)
		Average constant value: 7.9147724735703 	A= 6   B= 30   C= 50
		...

We see we have a result with a score of 100. Nice!

We should then look in the constants box on the right to see which equation we should use. We get:
		Constant Array 40 = answer / ((B - A) * (C / 2) + A * C)

Variables A, B, and C are from the actual problem:
	A = 20
	B = 40
	C = 5

"Constant Array 40" is the "Average constant value", which is 1 (as you see from the output above). 

We know have our equation to solve:
		1 = answer / ((40 - 20) * (5 / 2) +20 * 5)

Solving:
		1 = answer / 150
		answer = 150

We now have our answer: 150. You can use the Webassign Solver to solve any sort of math-based problem, as long as the problem lets you use practice problems.

Enjoy!