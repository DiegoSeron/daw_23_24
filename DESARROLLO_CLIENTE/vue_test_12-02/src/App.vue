<script setup lang="ts">
//import { RouterLink, RouterView } from 'vue-router'
import HelloWorld from './components/HelloWorld.vue'
import { reactive } from 'vue';
interface Post {
  id: number,
  userId: number,
  title: string,
  body: string
}

let posts = reactive(new Array<Post>());


function get() {
  fetch('https://jsonplaceholder.typicode.com/posts')
    .then(res => res.json())
    .then(data => {
      console.log(`data from posts ${data}`);
      posts.push(...data);
      // posts = data;
    })
}

get();



</script>

<template>
  <header>
    <img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="125" height="125" />

    <table>
      <thead>
        <tr>
          <td>USERId</td>
          <td>ID</td>
          <td>TITLE</td>
          <td>BODY</td>
          <td>BODY SIZE</td>
        </tr>
      </thead>
      <tbody>

        <tr v-for="post in posts">
          <template v-if="post.body.length < 150">
            <td>{{ post.userId }}</td>
            <td>{{ post.id }}</td>
            <td>{{ post.title }}</td>
            <td>{{ post.body }}</td>
            <td>{{ post.body.length }}</td>
          </template>
        </tr>
      </tbody>
    </table>
  </header>
</template>

<style scoped>
header {
  line-height: 1.5;
  max-height: 100vh;
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: 100%;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
}

nav a.router-link-exact-active {
  color: var(--color-text);
}

nav a.router-link-exact-active:hover {
  background-color: transparent;
}

nav a {
  display: inline-block;
  padding: 0 1rem;
  border-left: 1px solid var(--color-border);
}

nav a:first-of-type {
  border: 0;
}

@media (min-width: 1024px) {
  header {
    display: flex;
    place-items: center;
    padding-right: calc(var(--section-gap) / 2);
  }

  .logo {
    margin: 0 2rem 0 0;
  }

  header .wrapper {
    display: flex;
    place-items: flex-start;
    flex-wrap: wrap;
  }

  nav {
    text-align: left;
    margin-left: -1rem;
    font-size: 1rem;

    padding: 1rem 0;
    margin-top: 1rem;
  }
}
</style>
