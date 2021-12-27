// library to exc the python
const spawn = require("child_process").spawn;

// create our executor. pass file path and inputs
const exc = spawn("python", ["process.py", 10, 20]);

// callback: when we get data, print the it. data is raw so we convert to string
exc.stdout.on("data", raw => {
    console.log(raw.toString());
})