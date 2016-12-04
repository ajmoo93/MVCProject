$(function myfunction(){
    $("#Dialog-modal".dialog({

        width: 450,
        height: 250,
        show:{
            effect: "shake",
            duration: 100
        },
        hide: {
            effect: "explode",
            duration: 500
        }
    })
    
    )

});