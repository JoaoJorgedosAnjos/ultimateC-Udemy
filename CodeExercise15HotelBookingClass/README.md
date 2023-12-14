# HotelBooking class
Define a HotelBooking class, which will contain the following fields that must be accessible outside of this class:

1. GuestName (string)

2. StartDate and EndDate (DateTimes)

The constructor of this class should take the following parameters (please maintain the given order and names):

1. guestName (string)

2. startDate (DateTime)

3. lengthOfStayInDays (int)

The constructor should set all fields of this class.

The EndDate should be calculated in the constructor as the StartDate plus the lengthOfStayInDays . You can use the AddDays method from the DateTime type to calculate it. You can do it right in the constructor body.
