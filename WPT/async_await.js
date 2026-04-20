function getData() {
    return new Promise(function(resolve, reject) {

        setTimeout(function() {
            resolve("Data received");
        }, 2000);

    });
}
async function display() {

    console.log("Start");

    let result = await getData();

    console.log(result);

    console.log("End");

}

display();