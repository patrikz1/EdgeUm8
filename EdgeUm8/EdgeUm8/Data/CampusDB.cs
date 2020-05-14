﻿//using System;
//using System.Collections.Generic;
//using System.Text;
//using EdgeUm8.Interfaces;
//using EdgeUm8.Models;
//using System.Linq;
//using Xamarin.Forms;
//using SQLite;

//namespace EdgeUm8.Data
//{
//    public class CampusDB
//    {
//        private SQLiteConnection _SQLiteConnection;

//        public CampusDB() {

//            _SQLiteConnection = DependencyService.Get<ISQLiteInterface>().GetSQLiteConnection();

//            _SQLiteConnection.CreateTable<House>();
//            _SQLiteConnection.CreateTable<HouseRoom>();
//            _SQLiteConnection.CreateTable<AvailableTimes>();
//        }

//        public IEnumerable<House> GetHouses() {

//            return (from h in _SQLiteConnection.Table<House>()

//                    select h).ToList();

//        }

//        public IEnumerable<HouseRoom> GetRooms() {

//            return (from r in _SQLiteConnection.Table<HouseRoom>()

//                    select r).ToList();
//        }

//        public AvailableTimesViewModel GetFreeTimesForRoom(string roomId) {
                        
//            var data = _SQLiteConnection.Table<AvailableTimes>();
//            List<AvailableTimes> tempTimes = data.Where(t => t.RoomId == roomId).ToList();
//            var allTimes = new AvailableTimesViewModel() { RoomId = roomId, TimesForRoom = tempTimes };

//            return allTimes;
//        }

//        public House GetSpecificHouse(int id) {

//            return _SQLiteConnection.Table<House>().FirstOrDefault(t => t.Id == id);

//        }

//        public void DeleteUser(int id) {

//            _SQLiteConnection.Delete<User>(id);

//        }

//        public string AddUser(User user) {

//            var data = _SQLiteConnection.Table<User>();

//            var d1 = data.Where(x => x.Email == user.Email && x.UserName == user.UserName).FirstOrDefault();

//            if (d1 == null) {

//                _SQLiteConnection.Insert(user);

//                return "User Sucessfully Registered!";

//            } else

//                return "Already Mail id Exist";

//        }

//        public bool updateUserValidation(string userid) {

//            var data = _SQLiteConnection.Table<User>();

//            var d1 = (from values in data

//                      where values.Email == userid

//                      select values).Single();

//            if (d1 != null) {

//                return true;

//            } else

//                return false;

//        }

//        public bool updateUser(string username, string pwd) {

//            var data = _SQLiteConnection.Table<User>();

//            var d1 = (from values in data

//                      where values.Email == username

//                      select values).Single();

//            if (true) {

//                d1.Password = pwd;

//                _SQLiteConnection.Update(d1);

//                return true;

//            } else {

//                return false;
//            }

//        }

//        public bool LoginValidate(string userName1, string pwd1) {

//            var data = _SQLiteConnection.Table<User>();

//            var d1 = data.Where(x => x.Email == userName1 && x.Password == pwd1).FirstOrDefault();

//            if (d1 != null) {

//                return true;

//            } else

//                return false;

//        }

//    }
//}

