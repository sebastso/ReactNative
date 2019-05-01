/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 * @flow
 */

import React, { Component } from "react";
import {
  Platform,
  StyleSheet,
  Text,
  Button,
  View,
  Linking
} from "react-native";

const instructions =
  "Press Ctrl+R to reload,\n" + "Shift+F10 or shake for dev menu";

submithandler = () => {
  Linking.openURL("https://www.hp.com/privacy");
};

export default class App extends Component<{}> {
  render() {
    return (
      <View style={styles.container}>
        <Text style={styles.welcome}>Welcome to React Native!</Text>
        <Text style={styles.instructions}>
          To get started, edit App.windows.js
        </Text>
        <Text style={styles.instructions}>{instructions}</Text>
        <Button onPress={() => submithandler()} title="Click ME" color="blue" />
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "#F5FCFF"
  },
  welcome: {
    fontSize: 20,
    textAlign: "center",
    margin: 10
  },
  instructions: {
    textAlign: "center",
    color: "#333333",
    marginBottom: 5
  }
});
