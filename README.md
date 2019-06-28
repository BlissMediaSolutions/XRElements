# XR Elements Coding Challnge

#### Author:
* Danielle Walker

#### Designed / Tested on:
* C# Programming Language
* MS Visual Studio Community 2015   

#### Assumptions:
* Only Valid Product Codes (SH3, YT2, TR) will be tested.  If another code is tried, it will return an error stating Invalid Product Code.  
* Only Valid Package size combinations will be entered & tested.  While it will test that the Qty is not less than 2, or a negative number,
  it will not function for an order of `TR` for a Qty of `4` (as TR products are available in Pack Sizes of 3, 5 or 9)
  
#### Expansion:
* The App can easily be expanded by simply adding another code to the enum `Product Code`, and implementing another class 
  which is derived from the Product Class.  Note - will need to define the Pack Sizes & Pack Prices within this dervied class constructor.
  
#### Limitations:
* The App is limited to only testing products with either 2 or 3 Pack Sizes.
* This App could be improved by utilizing CartesianProduct to work out all possible Pack Sizes.  Due to time constraints, this wasn't implemented.

#### Running the App:
* This is a Console App (and thus runs via the Command Line).
1) To run the App, simply run `xrelements` from the Command Line.
2) When Prompted, enter the Qty and Product Code for an order.  This should be something like `10 SH3`, and then hit enter.
3) Continue entering more orders, until you are done entering them.  This should then be something like:
```
28 YT2
12 TR
10 SH3 
```
4) Once finished entering all your orders, type: `-1` and this will signal to the program that there are no more orders, and that it should process those orders entered.
5) The Program will then generate all the number of Packs for an order, and calculate the Total.  This would result in an output which looks just like this (a sample of the whole screen):
```
Please Enter the Order (type '-1' to end order)
10 SH3
28 YT2
12 TR
-1

10 SH3 $8.98
2 x 5 $4.49

28 YT2 $29.80
2 x 10 $9.95
2 x 4 $4.95

12 TR $10.94
1 x 9 $7.99
1 x 3 $2.95
```
