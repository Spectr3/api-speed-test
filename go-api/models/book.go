package models

type book struct {
	ISBN	string	`json:"ISBN"`
	Title	string	`json:"Title"`
	Price	float64	`json:"Price"`
	Author 	author	`json:"Author"`
}

func getBooks(c *gin.Context) {
	var books = []book{
		{ISBN: "9780141187761", Title: "1984", author: {FirstName: "George", LastName: "Orwell"}, Price: 8.99},
		{ISBN: "9781528718820", Title: "Animal Farm", author: {FirstName: "George", LastName: "Orwell"}, Price: 9.99},
		{ISBN: "0571191479", Title: "Lord of the Flies", author: {FirstName: "William", LastName: "Golding"}, Price: 8.99},
		{ISBN: "9780099549482", Title: "To Kill and Mockingbird", author: {FirstName: "Harper", LastName: "Lee"}, Price: 6.99},
		{ISBN: "0007635745", Title: "The Code Book", author: {FirstName: "Simon", LastName: "Singh"}, Price: 7.99},
	}
	c.IndentedJSON(http.StatusOK, books)
}