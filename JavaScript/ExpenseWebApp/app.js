// app.js

// DEPENDENCIES
// ===============================================
var express = require("express"),
	app = express(),
	bodyParser = require("body-parser"),
	fs = require("fs");

// SETUP
// ===============================================

// Set up body-parser to parse JSON:
app.use(bodyParser.json());
// To parse form data:
app.use(bodyParser.urlencoded({ extended: true }));

//Custom middleware that logs each request in the console:
app.use(function (req, res, next) {
	console.log(`${req.method} request for '${req.url}'`);
	//so that it moves to the next middleware:
	next();
});

//ui files in client folder
app.use(express.static("./client"));

// DATABASE
// ===============================================

// Setup the database.
var Datastore = require('nedb');
var db = new Datastore({
  filename: 'expenses.db', // Provide a path to the database file.
  autoload: true, // Automatically load the database.
  timestampData: true // Add and manage the fields createdAt and updatedAt.
});


// ROUTES
// ===============================================

// GET all expenses.
// (Accessed at GET http://localhost:3000/expenses)
//-1 is reverse order
app.get('/expenses', function(req, res) {
  db.find({}).sort({ updatedAt: -1 }).exec(function(err, expenses) {
    if (err) res.send(err);
    res.json(expenses);
  });
});


// POST a new expense.
// (Accessed at POST http://localhost:3000/expenses)
app.post('/expenses', function(req, res) {
    var expense = {
    date: req.body.date,
    amount: req.body.amount,
    description: req.body.description,
    weekNum: req.body.week
    };
    

  db.insert(expense, function(err, expense) {
    if (err) res.send(err);
   // to use this route directly for the view 
    // until cleaner solution is implemented 
    // redirect instead of res.json 
    // res.json(expense);
    res.redirect('/');
  });
});


// START THE SERVER
// ===============================================
app.listen(3000);
console.log("express app running on port 3000");


//export module to be able to include this app instance in other files:
module.exports = app