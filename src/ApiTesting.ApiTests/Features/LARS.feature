Feature: LARS
		As a Course Directory Micoservice function
		I want to Access the LARS resource
		So that I retrieve LARS data for my searches

@lars
Scenario Outline: Sending a LARS post with No Facet
		Given a user is using the LARS resource
		When user sends LARS request with no facets <search>
		Then Response should contain the correct information
Examples:
| search          |
| biology         |
| hair and beauty |
| english         |
| beuaty          |
| hair            |
| plumming        |
| engineering     |
|                 |
| in              |
| (QCF)           |

@lars
Scenario Outline: Sending a LARS post with No Facet Special Chars
		Given a user is using the LARS resource
		When user sends LARS request with no facets <search>
		Then Response should contains zero records
Examples:
| search |
| &      |
| -      |
| (      |
| )      |
| '      |
| @      |
| +      |
| =      |
| :      |
| ,      |

@lars
Scenario Outline: Sending a LARS post with Facets
		Given a user is using the LARS resource
		When user sends LARS request with facets <search>, <count>, <facet1>, <facet2>, <filter1>, <filter2>
		Then Response should contain the correct information
Examples:
| search     | count | facet1             | facet2       | filter1                   | filter2                   |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '3' | AwardOrgCode eq 'EDEXCEL' |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '4' | AwardOrgCode eq 'EDEXCEL' |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '2' | AwardOrgCode eq 'IB'      |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '3' | AwardOrgCode eq 'IB'      |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '2' | AwardOrgCode eq 'AQA'     |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '2' | AwardOrgCode eq 'aqa'     |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '3' | AwardOrgCode eq 'AQA'     |
| biology    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '4' | AwardOrgCode eq 'AQA'     |
| ENGLISH    | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '7' | AwardOrgCode eq 'UOT'     |
| DENTAL     | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '5' | AwardOrgCode eq 'OU'      |
| dental     | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '6' | AwardOrgCode eq 'OU'      |
| medicine   | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq 'X' | AwardOrgCode eq 'NONE'    |
| APPRENTICE | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '1' | AwardOrgCode eq 'WBA'     |

@lars
Scenario: Sending a LARS post with One Facet no search term
		Given a user is using the LARS resource
		When user sends LARS request with one facet:
| search | count | facets             | filter                    |
|        | true  | NotionalNVQLevelv2 | NotionalNVQLevelv2 eq '2' |
		Then Response should contain the correct information

@lars
Scenario: Sending a LARS post with One Facet level 2
		Given a user is using the LARS resource
		When user sends LARS request with one facet:
| search  | count | facets             | filter                    |
| biology | true  | NotionalNVQLevelv2 | NotionalNVQLevelv2 eq '2' |
		Then Response should contain the correct information

@lars
Scenario: Sending a LARS post with One Facet level 3
		Given a user is using the LARS resource
		When user sends LARS request with one facet:
| search  | count | facets             | filter                    |
| biology | true  | NotionalNVQLevelv2 | NotionalNVQLevelv2 eq '3' |
		Then Response should contain the correct information

@lars
Scenario: Sending a LARS post with One Facet OrgCode
		Given a user is using the LARS resource
		When user sends LARS request with one facet:
| search  | count | facets       | filter                    |
| biology | true  | AwardOrgCode | AwardOrgCode eq 'EDEXCEL' |
		Then Response should contain the correct information

@lars
Scenario: Sending a LARS post with One Facet Hair and Beauty
		Given a user is using the LARS resource
		When user sends LARS request with one facet:
| search        | count | facets             | filter                    |
| geography | true  | NotionalNVQLevelv2 | NotionalNVQLevelv2 eq '4' |
		Then Response should contain the correct information

@lars
Scenario: Sending a LARS post with One Facet Hair and Beauty level 3
		Given a user is using the LARS resource
		When user sends LARS request with one facet:
| search        | count | facets             | filter                    |
| english | true  | NotionalNVQLevelv2 | NotionalNVQLevelv2 eq '3' |
		Then Response should contain the correct information

@lars
Scenario: Sending a LARS post with Two Facets
		Given a user is using the LARS resource
		When user sends LARS request with two facets:
| search  | count |facet1             | facet2       |  filter1                   | filter2                   |
| biology | true  |NotionalNVQLevelv2 | AwardOrgCode |  NotionalNVQLevelv2 eq '4' | AwardOrgCode eq 'EDEXCEL' |
		Then Response should contain the correct information

@lars
Scenario: Sending a LARS post with Two Facets no search term
		Given a user is using the LARS resource
		When user sends LARS request with two facets:
| search | count | facet1             | facet2       | filter1                   | filter2                   |
|        | true  | NotionalNVQLevelv2 | AwardOrgCode | NotionalNVQLevelv2 eq '4' | AwardOrgCode eq 'EDEXCEL' |
		Then Response should contain the correct information
