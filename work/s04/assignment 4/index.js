

const port    = process.env.DBWEBB_PORT || 1337;
const express = require("express");
const app     = express();
const routeIndex = require("./route/index.js");
const routeToday = require("./route/lotto.js");
const path = require("path");

app.use(express.static(path.join(__dirname, "report")));
app.use("/", routeIndex);
app.set("view engine", "ejs");
app.use("/lotto", routeToday);
app.listen(port);



console.info(`Server is listening on port ${port}.`);