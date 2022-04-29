async function getPost(){
    let url =  "https://jsonplaceholder.typicode.com/post";
    try{
        let response = await fetch(url);
        return await response.json()
    }catch (error){
        console.error();
    }
}