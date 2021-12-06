const spawn = require("child_process").spawn
const instance = spawn("python", ['process.py', 1, 2])
instance.stdout.on("data", data => console.log(data.toString()))