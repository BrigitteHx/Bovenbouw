const numbers= [5,10,15,20,25,30];  
const container = document.getElementById("container")

// var width = (window.innerWidth - 100) / 12;
// var height = (window.innerHeight - 100) / 6;

var width = 100;
var height = 20;
var clicks = 0;

console.log(width)
console.log(height)

var btn_num = parseInt(prompt("How many buttons do you want to create?  "));

function createButton (button_numbers){
  for(let number = 1; number < button_numbers +1; number++){
        let newBtn = document.createElement('button');
        var lineBreak = document.createElement("br");
      
        newBtn.innerText= number;
        document.querySelector('#container').appendChild(newBtn);
        // newBtn.onclick = function() {
        //   newBtn.style.backgroundColor= 'red';
        // };


        // change the color :
        newBtn.clicks = 0
        newBtn.addEventListener('click', function() {
          this.clicks++;
          newBtn.style.backgroundColor= 'orange';
          if (this.clicks == 2){
            newBtn.style.backgroundColor= 'pink';
          } else if (this.clicks == 3){
            newBtn.style.backgroundColor= 'indigo';
          } else if (this.clicks >= 4){
            newBtn.style.backgroundColor= 'black';
          } if (this.clicks >= 5){
            newBtn.remove();
          }
       });

        for (num in numbers){
          if (number == numbers[num]){
              document.querySelector('#container').appendChild(lineBreak);
            };
        }
      
      //   style
      //newBtn.style.padding = `111px 120px`;
        newBtn.style.padding = `${height}px ${width}px`;
        newBtn.style.margin = `10px`;
        newBtn.style.backgroundColor = "green";
        newBtn.style.color = "white";
        newBtn.style.fontFamily= "Serif";
        newBtn.style.fontSize = "45px";
  
      }
    };

createButton(parseInt(btn_num))



// container.addEventListener("click", function() { 
//   console.log(this.innerText + "You clicked me");
//   clicks += 1;
// });
