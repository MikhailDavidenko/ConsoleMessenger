<template>
  <v-app>
    <v-main>
      <HelloWorld/>
      <ScorerComp/>
    </v-main>
    
  </v-app>
</template>

<script>

import HelloWorld from './components/HelloWorld.vue'
import ScorerComp from './components/ScorerComp.vue'

export default {
  name: 'App',

  components: {
    HelloWorld,
    ScorerComp
  },

  data: () => ({
    //
  }),
}
</script>
