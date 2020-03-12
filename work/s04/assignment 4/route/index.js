var express = require('express');
var router  = express.Router();

// Add a route for the path /
router.get('/', (req, res) => {
    res.send("Assignment 3");
});

module.exports = router;