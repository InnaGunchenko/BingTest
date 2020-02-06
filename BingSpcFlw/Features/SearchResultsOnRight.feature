Feature: SearchResultsOnRight

@mytag
Scenario: Search Results On Right
	Given I have navigated to BingPage
	And I typed star wars episode vi in SearchInput on BingPage
	When I press key enter on the SearchInput on the BingPage
	Then I should navigate to BingSearchPage and 8 elements SearchResultsOnRight
