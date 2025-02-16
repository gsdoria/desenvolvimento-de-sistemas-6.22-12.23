import { post } from "./backend/backend";

let op = ['+','-','*','/','.','=']

export let str = ""

const strRep = (s, i, v)=>{
    return s.substring(0, i) + v + s.substring(i + 1);
}

const add = i => {

    if ( 
        !( 
            (
                op.includes(str.slice(-1)) 
                || 
                str.length<1 
            ) 
            && 
            op.includes(i) 
        )
        ||
        (
            str.length<1 
            &&
            (i=="+" || i=="-")
        )
    ){
        str += i
        document.querySelector("#p").innerHTML = str
    }
    
    else if (
        op.includes(str.slice(-1)) 
        &&
        op.includes(i)
    ) {
        str = strRep(str, str.length-1, i)
        document.querySelector("#p").innerHTML = str
    }


    if (str.slice(-1) == "="){
        console.log("s", str.slice(0,-1))
        console.log("e", eval(str.slice(0,-1)))

        document.querySelector("#p").innerHTML = eval(str.slice(0,-1))
        post(str+String(eval(str.slice(0,-1))))

        str = String(eval(str.slice(0,-1)))

    }

    console.log(str)
}


const clean = () => {
    str=""
    document.querySelector("#p").innerHTML = ""
}


const garbage = () => {

    str = ""
    document.querySelector("#p").innerHTML = str
}

export {add, clean, garbage}