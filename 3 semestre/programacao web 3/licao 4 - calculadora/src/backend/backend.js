async function get(){
    console.log("0get")
    const response = await fetch("http://localhost:3000/a",
        {
            method: 'GET',
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json',
            }
        }
    )
    .then(res => res.json())

    // response.forEach(e => {
    //     console.log(e)
    // });

    console.log("1get")
    return response
}

async function post(v){
    console.log("0post")

    const response = await fetch("http://localhost:3000/a",
        {
            method: 'POST',
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({v: v})
        }
    )
    .then(res => res.json())

    console.log(response)

    console.log("1post")
}

export {get, post}