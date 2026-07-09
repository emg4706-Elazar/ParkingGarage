# מערכת לניהול חניון עירוני


### תיאור המערכת

מערכת לניהול תנועת הרכבים, גביית אגרות חנייה, וניהול משאבי חניון.


רכיבים:
1. Vehicle
2. PrivateVehicle
3. DisabledVehicle
4. Motorcycle
5. CashTerminal
6. CreditCardTerminal
7. Orchestrator
8. PreOrder
9. OrderParking
10. Loggr
11. ParkingManagement
12. IPreOrderable
13. IPayable


Abstract Vehicle
fields: 
1. Id
2. HourlyRate

Methods:
1. EnterForParking
2. Exit
3. Pay
4. GetVehicleType





PrivateVehicle

Inherits from: Vehicle, IPreOrderable

fields: 
1. Id
2. HourlyRate

Methods:
1. EnterForParking
2. PreOrderParking
3. Exit
4. Pay
5. GetVehicleType


DisabledVehicle

Inherits from: Vehicle, IPreOrderable

fields: 
1. Id
2. HourlyRate

Methods:
1. EnterForParking
2. PreOrderParking
3. Exit
4. Pay
5. GetVehicleType


Motorcycle

Inherits from: Vehicle

fields: 
1. Id
2. HourlyRate

Methods:
1. EnterForParking
2. Exit
3. Pay
4. GetVehicleType


CashTerminal

Inerits from: IPayable

Methods:
Pay



CreditCardTerminal

Inerits from: IPayable

Methods:
Pay


ParkingManagement

fields:
Orders
PreOrders

Methods:
CreateOrder(string VehicleId, string ParkingId)
CreatePreOrder(string VehicleId)
CalculatePrice()
CloseOrder()
RunSummary()
HasPreOrder()

Logger 