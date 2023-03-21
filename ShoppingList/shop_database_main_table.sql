-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: shop_database
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `main_table`
--

DROP TABLE IF EXISTS shop_database.`main_table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE shop_database.`main_table` (
  `Rows` int NOT NULL AUTO_INCREMENT,
  `List_Items` text CHARACTER SET utf8 COLLATE utf8_hungarian_ci,
  `List_Items_DB` text CHARACTER SET utf8 COLLATE utf8_hungarian_ci,
  `Shop_Items` text COLLATE utf8mb4_hungarian_ci,
  `Shop_Items_DB` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  `Succeeded_buy` text COLLATE utf8mb4_hungarian_ci,
  `How_much` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  PRIMARY KEY (`Rows`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `main_table`
--

LOCK TABLES shop_database.`main_table` WRITE;
/*!40000 ALTER TABLE `main_table` DISABLE KEYS */;
INSERT INTO shop_database.`main_table` VALUES (1,'apple','1','apple','1','YES','1'),(2,'banana','2','banana','2','YES','2'),(3,'lemon','7','lemon','3','NO','3'),(4,'strawberry','3','strawberry','4','YES','3'),(5,'blueberry','6','blueberry','5','NO','5'),(6,'asd','asd','milk','6',NULL,NULL),(7,'asd','6','bread','7',NULL,NULL),(8,'','','butter','8',NULL,NULL),(9,'','','salad','9',NULL,NULL),(10,'','','paper','10',NULL,NULL),(14,'apple','1','apple','1',NULL,NULL),(15,'banana','2','banana','2',NULL,NULL),(16,'lemon','7','lemon','3',NULL,NULL),(17,'strawberry','3','strawberry','4',NULL,NULL),(18,'blueberry','6','blueberry','5',NULL,NULL),(19,'','','milk','6',NULL,NULL),(20,'','','bread','7',NULL,NULL),(21,'','','butter','8',NULL,NULL),(22,'','','salad','9',NULL,NULL),(23,'','','paper','10',NULL,NULL);
/*!40000 ALTER TABLE `main_table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-11 19:31:09
