var messageBuilder = function () {
    var message = null;
    var header = null;
    var p = null;

    return {
        createMessage: function (classList) {
            message = document.createElement("div" )
            message.className = "card mb-4 ";
            

            if (classList === undefined)
                classList = [];

            for (var i = 0; i < classList.length; i++) {
                message.classList.add(classList[i])
            }

            message.classList.add('message')
            return this;
        },
        withHeader: function (text) {
            header = document.createElement("header")
            header.className = "h5 g-color-gray-dark-v1 mb-0";
            header.appendChild(document.createTextNode(text + ':'))
            return this;
        },
        withParagraph: function (text) {
            p = document.createElement("p")
            p.appendChild(document.createTextNode(text))
            return this;
        },
        
        build: function () {
            divimg = document.createElement("div")
            divimg.className = "g-mb-15";
            
            divmess = document.createElement("div")
            divmess.className = "card-body-inline px-4";
            
            divtitleowner = document.createElement("div")
            divtitleowner.className = "g-mb-15"
            
            divtitleowner.appendChild(header)
            
            divmess.appendChild(divtitleowner)
            divmess.appendChild(p)
            
            divimg.appendChild(divmess)
            message.appendChild(divimg);
            return message;
        }
    }
}