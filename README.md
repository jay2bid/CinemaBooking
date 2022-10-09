# Cinnamon Cinemas Movie Theatre Booking System 

Cinnamon Cinemas 🎥 Business Requirements

🎥. The Cinnamon Cinemas Movie Theatre has 15 seats, arranged in 3 rows of 5

- Rows are assigned a letter from A to C
- Seats are assigned a number from 1 to 5
User Story
As a 🍿 🎬 Cinnamon Cinemas Movie Theatre Manager
I want to allocate seats to customers
So that I can control reserved seating for the theatre

- GIVEN a customer wants to request some tickets
- WHEN they request a number of seats between 1 and 3 for a movie
- THEN the customer should be allocated the required number of seats
from the available seats on the seating plan
- AND the seats should be recorded as allocated

This solution is a demo of the Cinnamon Cinema Booking system

## How to start the Demo
This program is a Console application created in visual studio .Net6.0+

## Program Output
<img width="547" alt="Screenshot 2022-10-09 at 22 07 32" src="https://user-images.githubusercontent.com/108285095/194779528-38e47719-d962-423b-a4d7-73abfc602cbc.png">



## Development framework
The progam was developed using TDD
## Test Cases
Each class has its own test file, you can test the compete tests in visual studio 
## Assumptions:
- The Row and Collums are fixed to the requirements and cannot be changed, however this can be implemented easily
- Each Booking would like to be seated next to each other
- The Demo randolmy generates bookings to simulate real life scenarios
- The demo will keep on generating bookings till the cinema is full 

