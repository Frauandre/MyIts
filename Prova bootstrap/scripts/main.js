const Http_Methods = {
    GET: 'GET',
    POST: 'POST',
    PATCH: 'PATCH',
    DELETE: 'DELETE'
};

const Base_Url = {
    localhost: 'localhost:8080',
    staging: '161.35.219.110:3030'
}


/**
 *
 * @returns {Promise<void>}
 */
async function manageSlideShow() {
    let url = "http://" + Base_Url.localhost + "/match";
    let res = await newApiRequest(url, Http_Methods.POST);

    let htmlBlock = "";
    let initialWords = res.initialSuggestedWords;

    if(initialWords){
        for(word of initialWords){
            htmlBlock = htmlBlock + "<div>" + word + "</div>";
        }
    }
    document.getElementById("initialWords").innerHTML = htmlBlock;
}

async function submitLetters(requestBody) {
    let url = "http://" + Base_Url.localhost + "/words";
    let res = await newApiRequest(url, Http_Methods.POST, requestBody);

    let suggestionsArea = document.getElementById("suggestions");

    suggestionsArea.style.display = "block";

    console.log(res)


}


const form = document.getElementById('formArea')
form.addEventListener('submit', async (e) => {
    e.preventDefault()

    const form = e.currentTarget;


    try {
        const formData = new FormData(form);
        const plainFormData = Object.fromEntries(formData.entries());

        let requestBody = convertToApiRequestObject(plainFormData);

        await submitLetters(requestBody);

    } catch (error) {
        console.error(error);
    }
})

function convertToApiRequestObject(plainFormData) {
    let result = {
        submittedWord: {
            greenLetters: [
                {
                    pos: 0,
                    value: plainFormData['greenCell-0']
                },
                {
                    pos: 1,
                    value: plainFormData['greenCell-1']
                },
                {
                    pos: 2,
                    value: plainFormData['greenCell-2']
                },
                {
                    pos: 3,
                    value: plainFormData['greenCell-3']
                },
                {
                    pos: 4,
                    value: plainFormData['greenCell-4']
                }
            ],
            yellowLetters: [
                {
                    pos: 0,
                    value: plainFormData['yellowCell-0']
                },
                {
                    pos: 1,
                    value: plainFormData['yellowCell-1']
                },
                {
                    pos: 2,
                    value: plainFormData['yellowCell-2']
                },
                {
                    pos: 3,
                    value: plainFormData['yellowCell-3']
                },
                {
                    pos: 4,
                    value: plainFormData['yellowCell-4']
                }
            ],
            greyLetters: [
                {
                    pos: 0,
                    value: plainFormData['greyCell-0']
                },
                {
                    pos: 1,
                    value: plainFormData['greyCell-1']
                },
                {
                    pos: 2,
                    value: plainFormData['greyCell-2']
                },
                {
                    pos: 3,
                    value: plainFormData['greyCell-3']
                },
                {
                    pos: 4,
                    value: plainFormData['greyCell-4']
                }
            ]
        }
    }

    return result;
}


/*let input = document.getElementById("submitLettersBtn");
console.log(input)
input.addEventListener("click", (event) => {
    console.log('aa')
    event.preventDefault();
})*/





/* ----------------------------------------------------------------- */
/*                        API-RELATED FUNCTIONS                      */
/* ----------------------------------------------------------------- */


/**
 *
 * @param url
 * @param HTTP_Method
 * @param body
 * @returns {Promise<any>}
 */
async function newApiRequest(url, HTTP_Method, body = null ) {

    let requestOptions;
    if (body == null) {
        requestOptions = {
            method: HTTP_Method,
            mode: 'cors',
            headers: new Headers({
                "Content-Type": "application/json"
            }),
        };
    } else {
        requestOptions = {
            method: HTTP_Method,
            mode: 'cors',
            headers: new Headers({
                "Content-Type": "application/json"
            }),
            body: JSON.stringify(body)
        };

    }

    const response = await fetch(url, requestOptions);
    return await response.json();
    /*
        .then(response => response.text())
        .then(result => console.log(JSON.parse(result)))
        .catch(error => console.log('error', error));
        */
}


manageSlideShow();
