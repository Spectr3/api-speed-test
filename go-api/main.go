package main

import (
    "github.com/gin-gonic/gin"
	"github.com/spectr3/api-speed-test/go-api/models"
)

func main(){
	router := gin.Default()
	router.GET("/books", models.GetBooks)

	router.Run("localhost:5000")
}