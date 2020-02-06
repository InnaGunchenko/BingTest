Feature: ValidationUser

	Scenario Outline: Check validation name
	Given I have navigated to BingPage
	And click on SignIn on BingPage
	And I typed <userName> in UserInput on BingSignInPage
	When I press key enter on the UserInput on the BingSignInPage
	Then I can see the PasswordInput on the BingSignInPage

	Examples:
	| userName	|
	| gooines	|
	| bing		|