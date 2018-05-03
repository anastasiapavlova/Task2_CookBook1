CREATE DATABASE [CookBook]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CookBook', FILENAME = N'C:\CookBook.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CookBook_log', FILENAME = N'C:\CookBook.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO