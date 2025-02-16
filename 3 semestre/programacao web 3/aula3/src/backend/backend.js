async function get(path){
    console.log("0get")
    const response = await fetch(`http://localhost:3000/${path}`,
        {
            method: 'GET',
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json',
            }
        }
    )
    .then(res => res.json())

    console.log("1get")
    return response
}

async function post(path, v){
    console.log("0post")

    const response = await fetch(`http://localhost:3000/${path}`,
        {
            method: 'POST',
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(v)
        }
    )
    .then(res => res.json())

    console.log(response)

    console.log("1post")
}


async function del(path){
    console.log("0del")

    const response = await fetch(`http://localhost:3000/${path}`,
        {
            method: 'DELETE',
            mode: 'cors',
            headers: {
                'Content-Type': 'application/json',
            },
            // body: JSON.stringify(v)
        }
    )
    .then(res => res.json())

    console.log(response)

    console.log("1del")
}

export {get, post, del}