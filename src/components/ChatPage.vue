<template>
  <v-conteiner>
    <div id="example1">
      <button v-on:click="counter += 1">+1</button>
      <p>You pressed the button {{counter}} times</p>
    </div>
  </v-conteiner>
</template>

<script>
export default {
  // Data model
  data: () => {
    return{
      counter: 0,
      username: '',
      message: '',
      messages: [],
      intervalCtx: null,
      lastMsgId:0,
    }
  },
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
 *{
  text-align: left;
 }
  p{
    color: rgb(138, 88, 138);
  }
  button{
    background-color: skyblue;
    width: 35px;
    height: 25px;
  }
  button:hover{
    background-color: rgb(58, 131, 160);
    width: 43px;
    height: 30px;
  }
  button:active{
    background-color: rgb(104, 78, 116);
    width: 46px;
    height: 33px;
  }
  
  
</style>
