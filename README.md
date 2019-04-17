# RIMROCK API

```
"An API in support of project Rimrock, a website that allows you to lookup climbing locations and gear retailers
```

Project Midterm, one week sprint.

Members:

[Dan](https://github.com/daniellogerstedt),
[Ben](https://github.com/BenSTay),
[Jason](https://github.com/jasonb315),
[Andrew](https://github.com/amjcurtis)

---

## USER STORIES

[GO TO FILE](https://github.com/house-rimrock/rimrock/blob/master/UserStories.txt)

---

## DB SCHEMA

>NOTE: Database schema is split between API and MVC [go to mvc git >>](https://github.com/house-rimrock/rimrock)

![DBSchema](https://github.com/house-rimrock/rimrock/blob/master/assets/db-schema-rimrock.png)

---

## ENDPOINTS AND DATA


**for interactive Swagger documentation of API endpoints visit:**

**https://rimrockapi.azurewebsites.net/swagger**



```C#
https://rimrockapi.azurewebsites.net/api/location/

Returns: List of class Location: List<Location>

    [
    {"id":1,"name":"Cliff Creek","cost":"$$$$$","regionID":1},
    {"id":2,"name":"Long Shore","cost":"$$","regionID":1},
    {"id":3,"name":"Peakies","cost":"$$$$","regionID":1},
    {"id":4,"name":"Big Rock","cost":"$$$","regionID":1},
    {"id":5,"name":"Little Rocks","cost":"$","regionID":1}
    ]
```

```C#
https://rimrockapi.azurewebsites.net/api/location/{id}

Returns: class Location by id prop: 

    {"id":1,"name":"Cliff Creek","cost":"$$$$$","regionID":1}
```

```C#
https://rimrockapi.azurewebsites.net/api/retailer/

Returns: List of class Retailer: List<Retailer>

    [
    {"id":1,"name":"Second Ascents","specialty":"Climbing","regionID":1},
    {"id":2,"name":"Yeager's","specialty":"Skiing","regionID":1},
    {"id":3,"name":"Backcountry Essentials","specialty":"Climbing","regionID":1}
    ]
```

```C#
https://rimrockapi.azurewebsites.net/api/retailer/{id}

Returns: class Retailer by id prop: 

    {"id":1,"name":"Second Ascents","specialty":"Climbing","regionID":1}
```
```C#
https://rimrockapi.azurewebsites.net/api/region/

Returns: List of class Region: List<Region>

    [
    {"id":1,"name":"Greater Seattle"}
    {"id":2,"name":"Eastern Washington"}
    ]
```

```C#
https://rimrockapi.azurewebsites.net/api/region/{id}

Returns: class Region by id prop: 

    {"id":1,"name":"Greater Seattle"}
```

---

## Change Log

0.1.0: 12APR2019 *Initial publish*

1.0.0: 15APR2019 Deployed; data avaliable from browser.

1.1.0 16APR2019 README overhaul

1.2.0 17APR2019 Swagger docs

                seed data expansion