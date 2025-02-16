import "./App.css";
import {get, post} from './backend/backend'
import {add, clean, garbage, str} from './calcFuncoes'
// import {clean, garbage, str} from './calcFuncoes'

function App() {

// Não sei oq faz

  let a = get().then(e=>e.json())
  // async function r():Promise{
  console.log("sasasasas",a)

  // }
  const myAsynFunction = async ()=> {
    return await get().then(e=>e.json())
}
  // let r = async ()=>await get()
    //(res: { json: () => any; })=>res.json())

  // a = r()

  console.log("dsadasdasdasd",myAsynFunction())

  console.log(a)

  // Fim não sei oq faz
  
  return (
    <h1 className="text-3xl font-bold underline">
      Hello world!
    </h1>)
//     <>
// {/* Calculadora */}
//       <main className="bg-blue-500 w-full h-screen flex items-center justify-center gap-6">
//         <section>
//           <div className="bg-slate-800 h-[350px] rounded-b-lg rounded-t-lg">
//             <div className="bg-white w-64 pt-12 rounded-t-lg">
// {/* Input Calculadora */}
//               <input
//                 type="text"
//                 value={str}
//                 id="p"
//                 className=" w-64 py-4 text-slate-800 font-semibold text-2xl text-right pr-3"
//               />
//             </div>
//             <div className="flex pt-5">
//               <section className="w-full h-52 text-white pl-4">
//                 <div className="flex font-semibold justify-center">
// {/* 9 */}
//                   <button
//                     onClick={()=>add("9")}
//                     value={"9"}
//                     id="buttonNine"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     9
//                   </button>
// {/* 8 */}
//                   <button
//                     onClick={()=>add("8")}
//                     id="buttonEight"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     8
//                   </button>
// {/* 7 */}
//                   <button
//                     onClick={()=>add("7")}
//                     id="buttonSeven"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     7
//                   </button>
//                 </div>

//                 <div className="flex font-semibold justify-center">
// {/* 6 */}
//                   <button
//                     onClick={()=>add("6")}
//                     id="buttonSix"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     6
//                   </button>
// {/* 5 */}
//                   <button
//                     onClick={()=>add("5")}
//                     id="buttonFive"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     5
//                   </button>
// {/* 4 */}
//                   <button
//                     onClick={()=>add("4")}
//                     id="buttonFour"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     4
//                   </button>
//                 </div>

//                 <div className="flex font-semibold justify-center">
// {/* 3 */}
//                   <button
//                     onClick={()=>add("3")}
//                     id="buttonThree"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     3
//                   </button>
// {/* 2 */}
//                   <button
//                     onClick={()=>add("2")}
//                     id="buttonTwo"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     2
//                   </button>
// {/* 1 */}
//                   <button
//                     onClick={()=>add("1")}
//                     id="buttonOne"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     1
//                   </button>
//                 </div>
// {/* Apagar um por um */}
//                 <div className="flex font-semibold justify-center">
//                   <button
//                     onClick={()=>clean()}
//                     className="p-2 hover:bg-slate-600"
//                   >
//                     <svg
//                       className="fill-white"
//                       xmlns="http://www.w3.org/2000/svg"
//                       height="24"
//                       viewBox="0 -960 960 960"
//                       width="24"
//                     >
//                       <path d="M360-200q-20 0-37.5-9T294-234L120-480l174-246q11-16 28.5-25t37.5-9h400q33 0 56.5 23.5T840-680v400q0 33-23.5 56.5T760-200H360Zm400-80v-400 400Zm-400 0h400v-400H360L218-480l142 200Zm96-40 104-104 104 104 56-56-104-104 104-104-56-56-104 104-104-104-56 56 104 104-104 104 56 56Z" />
//                     </svg>
//                   </button>
// {/* Zero */}
//                   <button
//                     onClick={()=>add("0")}
//                     id="buttonZero"
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     0
//                   </button>
// {/* Lixeira */}
//                   <button
//                     onClick={garbage}
//                     className="p-2 hover:bg-slate-600"
//                   >
//                     <svg
//                       className="fill-white"
//                       xmlns="http://www.w3.org/2000/svg"
//                       height="24"
//                       viewBox="0 -960 960 960"
//                       width="24"
//                     >
//                       <path d="M280-120q-33 0-56.5-23.5T200-200v-520h-40v-80h200v-40h240v40h200v80h-40v520q0 33-23.5 56.5T680-120H280Zm400-600H280v520h400v-520ZM360-280h80v-360h-80v360Zm160 0h80v-360h-80v360ZM280-720v520-520Z" />
//                     </svg>
//                   </button>
//                 </div>
// {/* Ponto */}
//                 <div className="flex font-semibold justify-center">
//                   <button
//                     onClick={()=>add(".")}
//                     id="buttonOne"
//                     value={"."}
//                     className="p-2 pl-4 pr-4 hover:bg-slate-600"
//                   >
//                     •
//                   </button>
//                 </div>
//               </section>
// {/* Divisão */}
//               <section className="h-52 flex flex-col">
//                 <button onClick={()=>add("/")} className="p-2 hover:bg-slate-600">
//                   <svg
//                     className="fill-white"
//                     xmlns="http://www.w3.org/2000/svg"
//                     height="24"
//                     viewBox="0 -960 960 960"
//                     width="24"
//                   >
//                     <path d="M199-199q-9-9-9-21t9-21l520-520q9-9 21-9t21 9q9 9 9 21t-9 21L241-199q-9 9-21 9t-21-9Z" />
//                   </svg>
//                 </button>
// {/* Multiplicação */}
//                 <button onClick={()=>add("*")} className="p-2 hover:bg-slate-600">
//                   <svg
//                     className="fill-white"
//                     xmlns="http://www.w3.org/2000/svg"
//                     height="24"
//                     viewBox="0 -960 960 960"
//                     width="24"
//                   >
//                     <path d="m256-200-56-56 224-224-224-224 56-56 224 224 224-224 56 56-224 224 224 224-56 56-224-224-224 224Z" />
//                   </svg>
//                 </button>
// {/* Subtração */}
//                 <button onClick={()=>add("-")} className="p-2 hover:bg-slate-600">
//                   <svg
//                     className="fill-white"
//                     xmlns="http://www.w3.org/2000/svg"
//                     height="24"
//                     viewBox="0 -960 960 960"
//                     width="24"
//                   >
//                     <path d="M200-440v-80h560v80H200Z" />
//                   </svg>
//                 </button>
// {/* Soma */}
//                 <button onClick={()=>add("+")} className="p-2 hover:bg-slate-600">
//                   <svg
//                     className="fill-white"
//                     xmlns="http://www.w3.org/2000/svg"
//                     height="24"
//                     viewBox="0 -960 960 960"
//                     width="24"
//                   >
//                     <path d="M440-440H200v-80h240v-240h80v240h240v80H520v240h-80v-240Z" />
//                   </svg>
//                 </button>
// {/* Igual */}
//                 <button onClick={()=>add("=")} className="p-2 hover:bg-slate-600">
//                   <svg
//                     className="fill-white"
//                     xmlns="http://www.w3.org/2000/svg"
//                     height="24"
//                     viewBox="0 -960 960 960"
//                     width="24"
//                   >
//                     <path d="M160-280v-120h640v120H160Zm0-280v-120h640v120H160Z" />
//                   </svg>
//                 </button>
//               </section>
//             </div>
//           </div>
//         </section>

// {/* Local onde mostra o historico */}
//         <section>
//           <div id="a" className="bg-slate-800 h-[350px] w-64 rounded-b-lg rounded-t-lg text-white font-semibold">
//             <div className="flex flex-col p-4 h-[350px] w-64 rounded-b-lg">
//               {/* Mostrar historico aqui */}
//               {/* Beijo na bunda Dória */}
//               {/* Eu falhei */}
//               {
                
//               }
//             </div>
//           </div>
//         </section>
//       </main>
//     </>
//   );
}

export default App;
