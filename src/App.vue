<template>
  <v-app>
    <v-main>
      <MessageComponent/>
    </v-main>
    
  </v-app>
</template>

<script>

import MessageComponent from './components/MessageComp.vue'


export default {
  name: 'App',

  components: {
    MessageComponent,
  },

  //data: () => ({
    //
  //}),
}
</script>
