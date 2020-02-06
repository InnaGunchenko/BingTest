Feature: CheckTextOfElement

@mytag
Scenario: Check element text
	Given I have navigated to BingPage
	Then I search FooterList on BingPage and check text
	| LinkName            |
	| Privacy and Cookies |
	| Legal               |
	| Advertise           |
	| About our ads       |
	| Help                |
	| Feedback            |