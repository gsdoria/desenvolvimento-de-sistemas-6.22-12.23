import { useState } from "react";
import { post } from "../backend/backend";
import { useNavigate } from "react-router-dom";

export default function Postar({user}) {
    const [title, setTitle] = useState("")
    const [content, setContent] = useState("")
    const navigate = useNavigate();

    console.log(user)

    return (
        <>
            <h2>Criar post</h2>
            <input type="text" onInput={e=>setTitle(e.target.value)} placeholder="título"/>
            <input type="text" onInput={e=>setContent(e.target.value)} placeholder="conteúdo"/>
            <button onClick={()=>{
                if (title && content){
                    post("posts", {
                        user: user || "_blank",
                        title: title,
                        content: content,
                        time: new Date(),
                    })
                    navigate("/", {replace: true})
                }
            }}>
                postar
            </button>
        </>
    );
}

