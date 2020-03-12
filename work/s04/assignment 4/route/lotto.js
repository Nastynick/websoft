var express = require("express");
var router  = express.Router();

router.get("/", (req, res) => {
    let numbers = [];

    for (let i = 0; i < 7; i++) {
        let nr = Math.floor(Math.random() * (35-1+1) + 1);
        while (numbers.includes(nr)) {
            nr = Math.floor(Math.random() * (35-1+1) + 1);
        }
        numbers.push(nr)
    }

    let data = {};

    data.numbers = numbers;

    console.log(data);

    res.render("lotto", data);
});

module.exports = router;