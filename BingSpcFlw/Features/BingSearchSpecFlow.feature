Feature: BingSearchSpecFlow

	Scenario: Bing Search - SpecFlow
	Given I have navigated to BingPage
	And I typed SpecFlow in SearchInput on BingPage
	When I press key enter on the SearchInput on the BingPage
	And click on SerachResultSpecFlow on BingSearchPage
	Then I am presented with the "SpecFlow - Binding Business Requirements to .NET Code" homepage SpecFlowPage