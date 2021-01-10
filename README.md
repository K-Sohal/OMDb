# OMDb

## Project Overview
The main aim of this project is to create a test framework for a movie information service called ODMb API. Other aims are to incorporate good collaboration using GitHub and to follow the SCRUM framework when developing the project.

## Class Diagram

![](https://github.com/K-Sohal/OMDb/blob/main/Images/Class Diagram.png?raw=true "Class Diagram")

## Usage

In order to utilise this test framework, a valid API key for the OMDb API must be provided in the app.config file. In order to create a data transfer object (DTO), the service class must be initialised with query parameters. Valid parameters can be seen in the service class constructor overloads.

### Sprint 1

![](https://github.com/K-Sohal/OMDb/blob/main/Images/Sprint1.png?raw=true "Sprint 1")


Sprint Goals

Complete all project goals.

- [x] A complete test framework which tests all the data in a response
- [x] A sufficient number of commits and use of development branches.
- [x] A project board with a Scrum framework to help plan out the project.
- [x] Detailed README.md file that explains how to use the framework. Include a class diagram


## Project Review

All product backlog items have been "Done" and completed in one sprint. The project requirements were completed fairly quickly and so extra functionality in the form of query parameter testing was added. Only basic query parameter testing was done because multiple API calls are needed to test valid query permutations and the API had a limit on daily requests. In spite of this, an error was found in the API when providing a season and episode and querying the type as "movie". The API would still return the series details even though the type was "series" and not "movie". This shows how important parameter query testing is. As query parameter testing requires a different request string for each request, the constructor in the service class was overloaded to accomadate for the different types of queries. This solution was sufficient for this project however it is not viable for queries with the same number of parameters, for example searching by only IMDbID or only title. A more complete solution would be to pass custom types to the constructor rather than strings so that constructor overloading with the same number of parameters is possible. Additionally, a more well rounded test framework would also include load testing and security testing which were missing from the project requirements.

## Project Retrospective

Initially, too much time was spent on which API to test. Due to the nature of the project, the type of API had little impact on the outcome. Unfortunately the colloborative features of GitHub could not be utilised due to team member unavailability. Before any of the test framework was developed, the documentation of the API was read so that a solid understanding of the API and its features was gained. This information helped plan the development of the test framework and laid out the requirements. It reduced the risk of having to restructure code to test features discovered after the start of development. The project was a short one and so a relatively large amount of changes were added in each commit. In order to improve version control, a commit with a descriptive message could have been issued after each small change e.g. creation of a class.
