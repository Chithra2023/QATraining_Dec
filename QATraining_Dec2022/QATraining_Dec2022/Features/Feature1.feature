Feature: TMFeature

As a Turnup portal user
I would like to create, edit Time & Material records
So that I can manage employees time and material sucessfully

@tag1
Scenario: Create a time & material record with valid details
	Given I logged into turnup portal sucessfully
	When I navigated to Time & Material page
	And Create Time and Material Record
	Then The record should be created sucessfully
