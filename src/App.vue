<template>
  <v-app>
    <v-main>
      <img alt="Vue logo" src="./assets/logo.png">
      <ChatPage/>
      <HelloWorld/>
    </v-main>
  </v-app>
</template>

<script>
import ChatPage from './components/ChatPage.vue'
import HelloWorld from './components/HelloWorld.vue'

export default {
  name: 'App',
  components: {
    ChatPage,
    HelloWorld
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
  
}
*{
  background-color: rgb(236, 217, 248);
 }
</style>
