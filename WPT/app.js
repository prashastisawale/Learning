import axios from 'axios';

let url = "https://jsonplaceholder.typicode.com/users";

try {
    let response = await axios.get(url);

    console.log("Data fetched:\n");

    response.data.forEach(user => {
        console.log(user.name);
    });

} catch (error) {
    console.log("Error:", error.message);
}