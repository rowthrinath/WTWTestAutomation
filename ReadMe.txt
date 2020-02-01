Problem:

Table A is in Sterling, Table B is the conversion to Euros. Write a test to check the correctness of Table B in relation to Table A.
Consideration should be given to the variety of possible errors conditions and how these are tested. We are not concerned solely with whether or not the test works, but also with how tidy, structured and robust it is.
The test can be written in a suitable programming/scripting language of the candidate’s choice. A high level language (C# or Java) is preferred and commented pseudo-code is also possible if pressed for time.



Solution:

The test automation has been created in BDD and have used specflow/c sharp framework.

The tests are caetgorised as positive and negative scenarios 
	- Positive scenarios compares the euro table by taking data from sterling table and converting it to euro with 1.5 as the conversion rate
	- Negative scenario checks if the euro table doesnot have the correct conversion with a random conversion charge and zero



How to  run the test :

	- Copy project top local machine  
	- Open project in visual studio 2019 ideally or a version that supports .netCore
	- Build project
	- Access tests from Window - Test  Explorer and run all the tests


Read tests:

	- Scenarios are listed in CompareRateTables feature file

