<template>
  <v-app>
    <v-main>
      <ChatPage/>
    </v-main>
  </v-app>
</template>

<script>
import ChatPage from './components/ChatPage.vue'

export default {
  name: 'App',
  components: {
    ChatPage
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
