Feature: BingSearch

@mytag
Scenario: Bing should search and count result search
	Given I have navigated to BingPage
	And  I typed star wars episode vi in SearchInput on BingPage
	When I press key enter on the SearchInput on the BingPage
	Then I should navigate to BingSearchPage and 10 elements SearchResultsOnFirstPage