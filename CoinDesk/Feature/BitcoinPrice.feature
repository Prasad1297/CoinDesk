Feature: BitcoinPrice

A short summary of the feature

Scenario: [Finding the bitcoin price at given date]
	Given User is on "https://www.coindesk.com/price/bitcoin/" page 
	When when user gives "30 Dec 2021, 18:50 GMT+5:30" as input
	Then Bitcoin price at that time should be displayed
