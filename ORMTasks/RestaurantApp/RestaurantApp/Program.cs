// See https://aka.ms/new-console-template for more information

using RestaurantApp.Services;

RestaurantService restaurantService = new RestaurantService();
ReservationService reservationService = new ReservationService();
// await restaurantService.CreateRestaurant("The Gourmet Kitchen", 50, 4.5m);
// await restaurantService.CreateRestaurant("Seafood Delight", 80, 4.7m);
// await restaurantService.CreateRestaurant("Pasta Palace", 40, 4.3m);

//await restaurantService.UpdateRestaurant(1, "The Gourmet Kitchen Updated", 60, 4.6m);
//await restaurantService.DeleteRestaurant(1);
// await restaurantService.GetAllRestaurants();
// await reservationService.CreateReservation(2, "John Doe", DateTime.Now.AddDays(2), 4);
// await reservationService.CreateReservation(3, "John Doe", DateTime.Now.AddDays(2), 4);
//await reservationService.CompleteReservation(2);