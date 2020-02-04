Feature: CompareRateTables
	In order to compare two rate tables
	As a tester
	I want the below tests to compare the conversion rates


@mytag
Scenario Outline: To test the conversion rate for sterling to euro	
	Given I have two data tables created for sterling and euro currencies
	| Product   | ConversionRate   | SCurrency1   | SCurrency2   | SCurrency3   | SCurrency4   | STotal   | ECurrency1   | ECurrency2   | ECurrency3   | ECurrency4   | ETotal   |
	| <Product> | <ConversionRate> | <SCurrency1> | <SCurrency2> | <SCurrency3> | <SCurrency4> | <STotal> | <ECurrency1> | <ECurrency2> | <ECurrency3> | <ECurrency4> | <ETotal> |
	And I have set a conversion rate as
	| ConversionRate   |
	| <ConversionRate> |
	Then I should see the below conversion rates for sterling to euro
	| Product   | ConversionRate   | SCurrency1   | SCurrency2   | SCurrency3   | SCurrency4   | STotal   | ECurrency1   | ECurrency2   | ECurrency3   | ECurrency4   | ETotal   |
	| <Product> | <ConversionRate> | <SCurrency1> | <SCurrency2> | <SCurrency3> | <SCurrency4> | <STotal> | <ECurrency1> | <ECurrency2> | <ECurrency3> | <ECurrency4> | <ETotal> |

Examples:
| Product  | ConversionRate | SCurrency1 | SCurrency2 | SCurrency3 | SCurrency4 | STotal | ECurrency1 | ECurrency2 | ECurrency3 | ECurrency4 | ETotal |
| Product1 | 1.5            | 10         | 12         | 14         | 45         | 80     | 15         | 18         | 21         | 67.5       | 120    |
| Product2 | 1.5            | 20         | 15         | 24         | 0          | 87     | 30         | 22.5       | 36         | 0          | 130.5  |
| Product3 | 1.5            | 22         | 60         | 0          | 0          | 38     | 33         | 90         | 0          | 0          | 57     |
| Product4 | 1.5            | 28         | 0          | 0          | 0          | 45     | 42         | 0          | 0          | 0          | 67.5   |

@mytag
Scenario Outline: To test the conversion rate for sterling to euro	with incorrect conversion rate
	Given I have two data tables created for sterling and euro currencies
	| Product   |  SCurrency1   | SCurrency2   | SCurrency3   | SCurrency4   | STotal   | ECurrency1   | ECurrency2   | ECurrency3   | ECurrency4   | ETotal   |
	| <Product> |  <SCurrency1> | <SCurrency2> | <SCurrency3> | <SCurrency4> | <STotal> | <ECurrency1> | <ECurrency2> | <ECurrency3> | <ECurrency4> | <ETotal> |
	And I have set a conversion rate as
	| ConversionRate   |
	| <ConversionRate> |
	Then I should not see the below conversion rates for sterling to euro
	| Product  |  SCurrency1   | SCurrency2   | SCurrency3   | SCurrency4   | STotal   | ECurrency1   | ECurrency2   | ECurrency3   | ECurrency4   | ETotal   |
	| <Product> |  <SCurrency1> | <SCurrency2> | <SCurrency3> | <SCurrency4> | <STotal> | <ECurrency1> | <ECurrency2> | <ECurrency3> | <ECurrency4> | <ETotal> |

Examples:
| Product  | ConversionRate | SCurrency1 | SCurrency2 | SCurrency3 | SCurrency4 | STotal | ECurrency1 | ECurrency2 | ECurrency3 | ECurrency4 | ETotal |
| Product1 | 22.0           | 10         | 12         | 14         | 45         | 80     | 15         | 18         | 21         | 67.5       | 120    |

@mytag
Scenario Outline: To test the conversion rate for sterling to euro	with zero conversion rate
	Given I have two data tables created for sterling and euro currencies
	| Product   |  SCurrency1   | SCurrency2   | SCurrency3   | SCurrency4   | STotal   | ECurrency1   | ECurrency2   | ECurrency3   | ECurrency4   | ETotal   |
	| <Product> |  <SCurrency1> | <SCurrency2> | <SCurrency3> | <SCurrency4> | <STotal> | <ECurrency1> | <ECurrency2> | <ECurrency3> | <ECurrency4> | <ETotal> |
	And I have set a conversion rate as
	| ConversionRate   |
	| <ConversionRate> |
	Then I should not see the below conversion rates for sterling to euro
	| Product  |  SCurrency1   | SCurrency2   | SCurrency3   | SCurrency4   | STotal   | ECurrency1   | ECurrency2   | ECurrency3   | ECurrency4   | ETotal   |
	| <Product> |  <SCurrency1> | <SCurrency2> | <SCurrency3> | <SCurrency4> | <STotal> | <ECurrency1> | <ECurrency2> | <ECurrency3> | <ECurrency4> | <ETotal> |

Examples:
| Product  | ConversionRate | SCurrency1 | SCurrency2 | SCurrency3 | SCurrency4 | STotal | ECurrency1 | ECurrency2 | ECurrency3 | ECurrency4 | ETotal |
| Product1 | 0              | 10         | 12         | 14         | 45         | 80     | 15         | 18         | 21         | 67.5       | 120    |